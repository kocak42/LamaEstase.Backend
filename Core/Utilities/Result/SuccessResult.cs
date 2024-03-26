namespace Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string massage) : base(true, massage)
        {

        }
        public SuccessResult() : base(true)
        {

        }

    }
}
