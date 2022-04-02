namespace ServiceLifeTime
{
    internal class TransientLifeScopeService: ITransientLifeScopeService
    {
        private readonly ICounter counter;
        public string GetMessage()
        {
            return "How are you my friend? Transient";
        }
        public TransientLifeScopeService(ICounter counter)
        {
            this.counter = counter;
        }

        public int IncrementAndGet()
        {
            counter.Increment();
            return counter.Get();
        }
    }
}