namespace StatePattern.StatePattern
{
    class InProgressState : State
    {
        public override void HandleChangeStatusToSubmitted()
        {
            this._context.TransitionTo(new SubmittedState());
            Console.WriteLine("> Status changed to Submitted\n");
        }
    }
}
