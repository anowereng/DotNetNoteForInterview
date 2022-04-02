namespace ServiceLifeTime
{
    internal class ScopeLifeScopeService : IScopeLifeScopeService
    {
        private readonly ICounter counter;
        public string GetMessage()
        {
            return "How are you my friend? Scope";
        }
        public ScopeLifeScopeService(ICounter counter)
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