using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    //tu dong hiu cac phuong thuc
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposting)
        {
            if(!isDisposed && disposting)
            {
                DisposeCore();
            }
        }
        //Overide this to dispose custom object
        protected virtual void DisposeCore()
        {

        }



    }
}
