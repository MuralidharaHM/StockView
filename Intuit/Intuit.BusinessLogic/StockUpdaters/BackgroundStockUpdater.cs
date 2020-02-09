using Intuit.BusinessLogic.StockFetchers;
using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockUpdaters
{
    
    internal class BackgroundStockUpdater : IStockUpdater
    {
        IApiStockDataFetch _apiStockfetcher;
        BackgroundWorker _bWorker;

        int _frequency;

        public event NotifyUpdate Notify;

        List<IStockIdentity> _stocks;

        List<StockInfo> _stockInfos;
        internal BackgroundStockUpdater(IApiStockDataFetch apiStockFetch,List<IStockIdentity> stocks, int frequency)
        {
            _apiStockfetcher = apiStockFetch;
            _bWorker = new BackgroundWorker();
            _bWorker.DoWork += Fetch;
            _bWorker.RunWorkerCompleted += Completed;
            _stocks = stocks;
            _frequency = frequency;
            createStockInfo();

        }

        public void Dispose()
        {
            _bWorker.Dispose();
        }

        public void Start()
        {
             FetchHistorical();
            _bWorker.RunWorkerAsync();

        }

        
        private void createStockInfo()
        {
            _stockInfos = new List<StockInfo>();
            foreach (var item in _stocks)
            {
                _stockInfos.Add(new StockInfo() { ID = item.ID });
            }

        }
        private async void FetchHistorical()
        {
             var task= await _apiStockfetcher.GetStockDataAsync(_stocks, 1);
             mergeHistoricalStockList(task);

        }
        private  void Fetch(object sender, DoWorkEventArgs e)
        {
            
            if (_stocks.Count == 1)
            {
                mergeCurrentStockSingle(_apiStockfetcher.GetCurrentStockData(_stocks[0].ID));
            }
            else
            {
                mergeCurrentStockList(_apiStockfetcher.GetCurrentStockList(_stocks));
            }
           
            e.Result = _stockInfos;
        }

        private void mergeCurrentStockList(List<Stock> stock)
        {
            foreach (var item in stock)
            {
                mergeCurrentStockSingle(item);
            }
        }

        private void mergeCurrentStockSingle(Stock item)
        {
            var sInfo = _stockInfos.Where(a => a.ID == item.ID).FirstOrDefault();
            sInfo.Price = item.Price;
        }

        private void mergeHistoricalStockList(List<HistoricalStockData> stock)
        {
            foreach (var item in stock)
            {
                var sInfo = _stockInfos.Where(a => a.ID == item.ID).FirstOrDefault();
                sInfo.PrevDayPrice =item.Price;
                sInfo.High = item.High;
                sInfo.Low = item.Low;
            }
        }


        private async void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Notify != null && e.Result!=null)
            {
                Notify.BeginInvoke((List<StockInfo>)e.Result, null, null);
            }

             await Task.Delay(5000);

            _bWorker.RunWorkerAsync(); 
        }

        public void Stop()
        {
            if(_bWorker.IsBusy)
            _bWorker.CancelAsync();
        }
    }
}
