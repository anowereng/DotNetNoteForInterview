namespace ServiceLifeTime
{
    internal interface IScopeLifeScopeService
    {
        string GetMessage();
        int IncrementAndGet();
    }
}