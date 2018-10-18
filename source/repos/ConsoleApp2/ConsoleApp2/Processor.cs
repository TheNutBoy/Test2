
namespace ConsoleApp2
{
    interface IProcessor
    {
        void Finish();
        void Process(int i);
    }
    class Processor : IProcessor
    {
        public int Index;
        public Processor()
        {
            Logger.Log.Info("Процессор создан");
        }
        public void Finish()
        {
            Logger.Log.Info($"Finishing Process({Index})");
        }

        public void Process(int i)
        {
            Index = i;
            Logger.Log.Info($"Processing by ({Index})...");
        }
    }
}
