using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComProjectText : IComProjectText
    {
        private const string MessageNoSheetsOpened = "There are no sheets opened.";
        private const string MessageDone = "Done.";

        public void Run()
        {
            using (var containerInterop = new ContainerInterop())
            {
                var applicationInterface = containerInterop.Resolve<IApplicationInterface>();
                var jobInterface = containerInterop.Resolve<IJobInterface>();
                var textInterface = containerInterop.Resolve<ITextInterface>();

                var jobId = jobInterface.GetId();
                if (jobId == 0)
                {
                    applicationInterface.PutMessage(MessageNoSheetsOpened);
                    return;
                }

                dynamic jobTextIds = null;
                var jobTextCount = jobInterface.GetTextIds(ref jobTextIds);

                foreach (var jobTextId in jobTextIds)
                {
                    if (jobTextId == null)
                        continue;

                    textInterface.SetId(jobTextId);
                    textInterface.SetColour(5);

                    applicationInterface.PutMessage($"Text: {textInterface.GetText()} - Type: {textInterface.GetType()}");
                }

                applicationInterface.PutMessage(MessageDone);
            }
        }
    }
}
