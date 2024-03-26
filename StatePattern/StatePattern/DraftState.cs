namespace StatePattern.StatePattern
{
    class DraftState : State
    {
        public override void HandleChangeStatusToInProgress()
        {
            this._context.TransitionTo(new InProgressState());
            Console.WriteLine("> Status changed to InProgress\n");
        }
    }
}
