namespace StatePattern.StatePattern
{
    class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public virtual void HandleChangeStatusToInProgress()
        {
            NotAllowedException();
        }

        public virtual void HandleChangeStatusToSubmitted()
        {
            NotAllowedException();
        }
        public virtual void HandleChangeStatusToApproved()
        {
            NotAllowedException();
        }

        private void NotAllowedException()
        {
            Console.WriteLine("Cannot perform action");
            Console.WriteLine("> Invalid Status\n");
        }
    }

}
