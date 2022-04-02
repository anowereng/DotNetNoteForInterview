namespace ServiceLifeTime
{
    internal interface ITransientLifeScopeService
    {
        string GetMessage();
        int IncrementAndGet();
    }
}           