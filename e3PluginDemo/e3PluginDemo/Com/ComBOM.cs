using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComBOM : IComBOM
    {
        private const string Price = "Price";
        private const string Function = "Function";
        private const string Description = "Description";
        private const string Supplier = "Supplier";
        private const string WireCrosssection = "$WireCrosssection";
        private const string WireColour = "$WireColour";
        private const string Signal = "$Signal";
        private const string WireOuterDiameter = "$WireOuterDiameter";

        private const string Consumer = @"CSV|;|C:\Temp\GetBomPartList.csv";
        private const string OutputFormatVersion = "2.1";
        private const int Flags = 0;
        private const string KeyAttribute = "ArticleNumber";
        private const string QuantityAttribute = "Price";
        private const string LengthAttribute = "BOMLength";

        private const string MessageNoSheetsOpened = "There are no sheets opened.";
        private const string MessageDone = "Done: {0}.";

        public void Run()
        {
            using (var containerInterop = new ContainerInterop())
            {
                var applicationInterface = containerInterop.Resolve<IApplicationInterface>();
                var jobInterface = containerInterop.Resolve<IJobInterface>();

                var jobId = jobInterface.GetId();
                if (jobId == 0)
                {
                    applicationInterface.PutMessage(MessageNoSheetsOpened);
                    return;
                }

                dynamic additionalAttributes = new object[8];
                object result = null;

                additionalAttributes[0] = Price;
                additionalAttributes[1] = Function;
                additionalAttributes[2] = Description;
                additionalAttributes[3] = Supplier;
                additionalAttributes[4] = WireCrosssection;
                additionalAttributes[5] = WireColour;
                additionalAttributes[6] = Signal;
                additionalAttributes[7] = WireOuterDiameter;

                var ret = jobInterface.GetBomPartList(Consumer, OutputFormatVersion, Flags, KeyAttribute, QuantityAttribute, LengthAttribute, ref additionalAttributes, ref result);

                applicationInterface.PutMessage(string.Format(MessageDone, ret));
            }
        }
    }
}
