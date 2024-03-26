using StatePattern.StatePattern;

var context = new Context(new DraftState());
Console.WriteLine("Start processing: \n");

context.ChangeStatusToSubmitted();
context.ChangeStatusToInProgress();
context.ChangeStatusToSubmitted();


