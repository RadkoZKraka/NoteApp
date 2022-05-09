namespace NoteApp.Lib
{
    public class SingletonDataWrapper
    {
        private SingletonDataWrapper()
        {
            
        }

        private static SingletonDataWrapper instances = null;

        public static SingletonDataWrapper Instances
        {
            get
            {
                if (instances == null)
                {
                    instances = new SingletonDataWrapper();
                }

                return instances;
            }
        }
    }
}