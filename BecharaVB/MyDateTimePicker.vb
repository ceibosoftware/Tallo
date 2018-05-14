Public Class MyDateTimePicker
    Inherits System.Windows.Forms.DateTimePicker

    Private mTriangleLineColor As Color = Color.Blue
    Public Property TriangleLineColor() As Color
        Get
            Return Me.mTriangleLineColor
        End Get
        Set(ByVal value As Color)
            Me.mTriangleLineColor = value
            Me.Refresh()
        End Set
    End Property

    Private mTriangleLineWidth As Integer = 2
    Public Property TriangleLineWidth() As Integer
        Get
            Return Me.mTriangleLineWidth
        End Get
        Set(ByVal value As Integer)
            Me.mTriangleLineWidth = value
            Me.Refresh()
        End Set
    End Property

    Private mInitialColor As Color = Color.LightBlue
    Public Property InitialColor() As Color
        Get
            Return Me.mInitialColor
        End Get
        Set(ByVal value As Color)
            Me.mInitialColor = value
            Me.Refresh()
        End Set
    End Property

    Private mFontColor As Color = Color.Blue
    Public Property FontColor() As Color
        Get
            Return Me.mFontColor
        End Get
        Set(ByVal value As Color)
            Me.mFontColor = value
            Me.Refresh()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.FillRectangle(New SolidBrush(mInitialColor), 0, 0, Me.Width - 16, Me.Height)
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(FontColor), 0, 0)

        e.Graphics.DrawLine(New Pen(Me.mTriangleLineColor, mTriangleLineWidth), Me.Width - 16, 0, Me.Width - 8, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.mTriangleLineColor, mTriangleLineWidth), Me.Width - 8, Me.Height, Me.Width, 0)

    End Sub

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

End Class