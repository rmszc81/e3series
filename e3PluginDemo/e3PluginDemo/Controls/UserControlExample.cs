using System.Windows.Forms;

namespace e3PluginDemo.Controls
{
    using Com.Interfaces;

    public partial class UserControlExample : UserControl
    {
        private readonly IComBOM _comBOM;
        private readonly IComSheetText _comSheetText;
        private readonly IComProjectText _comProjectText;
        private readonly IComSheetHighlightSegment _comSheetHighlightSegment;

        public UserControlExample(IComBOM comBOM, IComSheetText comSheetText, IComProjectText comProjectText, IComSheetHighlightSegment comSheetHighlightSegment)
        {
            InitializeComponent();

            _comBOM = comBOM;
            _comSheetText = comSheetText;
            _comProjectText = comProjectText;
            _comSheetHighlightSegment = comSheetHighlightSegment;
        }

        private void BtnGetBomPartList_Click(object sender, System.EventArgs e)
        {
            try
            {
                ChangeButtonsState(false);

                _comBOM.Run();
            }
            finally
            {
                ChangeButtonsState(true);
            }
        }

        private void BtnSetSheetTextsColorAsRed_Click(object sender, System.EventArgs e)
        {
            try
            {
                ChangeButtonsState(false);

                _comSheetText.Run();
            }
            finally
            {
                ChangeButtonsState(true);
            }
        }

        private void BtnSetProjectTextsColorAsPurple_Click(object sender, System.EventArgs e)
        {
            try
            {
                ChangeButtonsState(false);

                _comProjectText.Run();
            }
            finally
            {
                ChangeButtonsState(true);
            }
        }

        private void BtnHighlightSegments_Click(object sender, System.EventArgs e)
        {
            try
            {
                ChangeButtonsState(false);

                _comSheetHighlightSegment.Run();
            }
            finally
            {
                ChangeButtonsState(true);
            }
        }

        private void ChangeButtonsState(bool enable)
        {
            btnGetBomPartList.Enabled = enable;
            btnSetSheetTextsColorAsRed.Enabled = enable;
            btnSetProjectTextsColorAsPurple.Enabled = enable;
            btnHighlightSegments.Enabled = enable;
        }
    }
}
