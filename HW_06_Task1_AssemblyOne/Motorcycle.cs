namespace HW_06_Task1_AssemblyOne
{
    public class Motorcycle // by default 'internal' (accessable only in current build). But let it make 'public' to be accessable in other dll
    {
        public int odometerPublic = 20_001;
        public void StartEnginePublic()
        {
        }

        protected int odometerProtected = 20_002;
        protected void StartEngineProtected()
        {
        }

        internal int odometerInternal = 20_003;
        internal void StartEngineInternal()
        {
        }

        protected internal int odometerProtectedInternal = 20_004;
        protected internal void StartEngineProtectedInterna()
        {
        }

        private int odometerPrivate = 20_005;
        private void StartEnginePrivate()
        {
        }

        private protected int odometerPrivateProtected = 20_006;
        private protected void StartEnginePrivateProtected()
        {
        }
    }
}
