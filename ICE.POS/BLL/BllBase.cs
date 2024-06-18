namespace ICE.POS
{

    using System;
    public class BllBase : IDisposable
    {
        protected PosDal _dal = new PosDal();

        public void dbClose()
        {
            this._dal.dbClose();
        }

        public bool dbOpen()
        {
            return this._dal.dbOpen();
        }

        public void Dispose()
        {
            this._dal.Dispose();
        }

        public bool IsConnected
        {
            get
            {
                return false;
            }
        }
    }
}

