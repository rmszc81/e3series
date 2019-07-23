using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComSheetHighlightSegment : IComSheetHighlightSegment
    {
        private const string MessageNoSheetsOpened = "There are no sheets opened.";
        private const string MessageDone = "Done.";

        public void Run()
        {
            using (var containerInterop = new ContainerInterop())
            {
                var applicationInterface = containerInterop.Resolve<IApplicationInterface>();
                var jobInterface = containerInterop.Resolve<IJobInterface>();
                var sheetInterface = containerInterop.Resolve<ISheetInterface>();
                var netSegmentInterface = containerInterop.Resolve<INetSegmentInterface>();

                var jobId = jobInterface.GetId();
                if (jobId == 0)
                {
                    applicationInterface.PutMessage(MessageNoSheetsOpened);
                    return;
                }

                dynamic sheetIds = null;
                var sheetCount = jobInterface.GetSheetIds(ref sheetIds);

                foreach (var sheetId in sheetIds)
                {
                    if (sheetId == null)
                        continue;

                    sheetInterface.SetId(sheetId);
                    applicationInterface.PutMessage($"Sheet name is: {sheetInterface.GetName()}{new string('-', 10)}");

                    dynamic netSegmentIds = null;
                    var netSegmentCount = sheetInterface.GetNetSegmentIds(ref netSegmentIds);

                    foreach (var netSegmentId in netSegmentIds)
                    {
                        if (netSegmentId == null)
                            continue;

                        netSegmentInterface.SetId(netSegmentId);
                        netSegmentInterface.Highlight();

                        applicationInterface.PutMessage($"Net segment: {netSegmentInterface.GetName()} - Type: {netSegmentInterface.GetType()}");
                    }
                }

                applicationInterface.PutMessage(MessageDone);
            }
        }
    }
}
