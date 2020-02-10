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
        public event NotifyUpdate Notify;

        IApiStockDataFetch _apiStockfetcher;
        BackgroundWorker _bWorker;
        int _frequency = 5000;

        List<IStockIdentity> _stocks;
        List<StockInfo> _stockInfos;
        internal BackgroundStockUpdater(IApiStockDataFetch apiStockFetch, int frequency)
        {
            _apiStockfetcher = apiStockFetch;
            _bWorker = new BackgroundWorker();
            _bWorker.DoWork += Fetch;
            _bWorker.RunWorkerCompleted += Completed;
            _bWorker.WorkerSupportsCancellation = true;
            _frequency = frequency;

        }

        public void Dispose()
        {
            _bWorker.Dispose();
        }

        public void Start(List<IStockIdentity> stocks)
        {
             _stocks = stocks;
            createStockInfo();
            FetchHistorical();

            if (!_bWorker.IsBusy)
            _bWorker.RunWorkerAsync();

        }
        public void Stop()
        {
            _bWorker.CancelAsync();
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
            if (_bWorker.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
            e.Result = _stockInfos;
        }


        private async void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (Notify != null && e.Result != null)
                {
                    Notify.BeginInvoke((List<StockInfo>)e.Result, null, null);
                }
            }

             await Task.Delay(_frequency);

            if (!_bWorker.CancellationPending && !e.Cancelled && !_bWorker.IsBusy) _bWorker.RunWorkerAsync(); ;
             
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

            var task = await _apiStockfetcher.GetStockDataAsync(_stocks, 1);
            mergeHistoricalStockList(task);

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
            if (sInfo != null)
            {
                sInfo.Price = item.Price;
                sInfo.Name = item.Name;
                sInfo.ID = item.Name;
            }
        }

        private void mergeHistoricalStockList(List<HistoricalStockData> stock)
        {
            foreach (var item in stock)
            {
                var sInfo = _stockInfos.Where(a => a.ID == item.ID).FirstOrDefault();
                if (sInfo != null)
                {
                    sInfo.PrevDayPrice = item.Price;
                    sInfo.High = item.High;
                    sInfo.Low = item.Low;
                }
            }
        }

        public void ChangeFrequency(int frequency)
        {
            _frequency = frequency;
        }
    }
}
