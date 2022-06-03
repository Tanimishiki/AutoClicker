using System.Runtime.InteropServices;

namespace AutoClicker;

public partial class Form1 : Form
{
    private bool _enabled;
    private bool _isPressed;

    [DllImport("user32.dll")]
    private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, ulong dwExtraInfo);
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int vKey);

    public Form1()
    {
        InitializeComponent();
    }

    private void StartButton(object sender, EventArgs e) =>
        SwitchMode();

    private void SwitchMode()
    {
        if (!_enabled)
        {
            _enabled = true;
            startButton1.Text = "Disable";
            startButton1.ForeColor = Color.Red;

            timerForMouseClick.Enabled = true;
            timerForMouseClick.Interval = CalculateTime();
            DisableInputs(true);
            return;
        }

        _enabled = false;
        startButton1.Text = "Enable";
        startButton1.ForeColor = Color.Green;
        timerForMouseClick.Enabled = false;
        DisableInputs(false);
    }

    private int CalculateTime()
    {
        int result = 0;

        if (hoursInput.Value > 0)
            result += 3600000 * (int) hoursInput.Value;
        if (minutesInput.Value > 0)
            result += 60000 * (int) minutesInput.Value;
        if (secondsInput.Value > 0)
            result += 1000 * (int) secondsInput.Value;
        if (millisecondsInput.Value > 0)
            result += (int) millisecondsInput.Value;

        if (result < 1)
        {
            result = 1;
            millisecondsInput.Value = result;
        }

        return result;
    }

    private void DisableInputs(bool disabled)
    {
        NumericUpDown[] arr = new NumericUpDown[] { hoursInput, minutesInput, secondsInput, millisecondsInput };
        foreach (NumericUpDown nud in arr)
            nud.Enabled = !disabled;
    }

    private void timerForKey_Tick(object sender, EventArgs e)
    {
        short state = GetAsyncKeyState(0x75); // 0x75 is a F6 key.
        if ((state == 0) || (state > 0))
        {
            _isPressed = false;
            return;
        }

        if (_isPressed) return;
        _isPressed = true;

        SwitchMode();
    }

    private void timerForMouseClick_Tick(object sender, EventArgs e)
    {
        if (Form.ActiveForm == this) return;
        mouse_event(2, MousePosition.X, MousePosition.Y, 0, 0);
        mouse_event(4, MousePosition.X, MousePosition.Y, 0, 0);
    }
}