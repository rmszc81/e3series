using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComSheetText : IComSheetText
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
                var textInterface = containerInterop.Resolve<ITextInterface>();

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

                    dynamic textIds = null;
                    var textCount = sheetInterface.GetTextIds(ref textIds);

                    foreach (var textId in textIds)
                    {
                        if (textId == null)
                            continue;

                        textInterface.SetId(textId);
                        textInterface.SetColour(13);

                        applicationInterface.PutMessage($"Text: {textInterface.GetText()} - Type: {textInterface.GetType()}");
                    }
                }

                applicationInterface.PutMessage(MessageDone);
            }
        }
    }
}
