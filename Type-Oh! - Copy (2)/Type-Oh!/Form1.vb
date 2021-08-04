Imports System.Net
Public Class Form1
    Dim length As Integer = 0
    Dim inputLength As Integer = 0
    Dim finalScore As String
    Dim copyTxt = " "
    Dim input = " "
    Dim score As Integer = 0
    Dim wordsMissed As Integer
    Dim timeInt As Integer = 0
    Dim time As Double = 0
    Function wordPlace()
        Dim i As Integer = 0
        copyTxt = Split(Label1.Text, " ") 'Everytime there is a space in the label, a new word in the array would be created
        length = UBound(copyTxt) - LBound(copyTxt) + 1 'Gets the number of words in the label
        input = Split((txtInput.Text), " ") 'Everytime there is a space in the textbox, a new word in the array would be created
        inputLength = UBound(input) - LBound(input) + 1 'Gets the number of words typed by user

        For i = 0 To inputLength - 1
            'MessageBox.Show(input(1))
            'MessageBox.Show(copyTxt(1))
            MessageBox.Show(length)

            If copyTxt(i) = input(i) Then
                score = score + 1
            End If

            'MessageBox.Show(x(i))
            'MessageBox.Show(copyTxt(0), input(0))
        Next
    End Function
    Public Shared value As Integer = 5
    Dim numWrongWords As Integer = 0
    Dim yea As Integer = value

    Private Sub btnNewText_Click(sender As Object, e As EventArgs) Handles btnNewText.Click
        Dim txtID As Integer
        txtID = Int((10 - 2) * Rnd())
        Select Case txtID
            Case 1
                Label1.Text = ""
        End Select
        'copyTxt = Split(Label1.Text, " ")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (Me.Height / 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (Me.Width / 2)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        Timer1.Enabled = True
        Dim ranNum1 As Integer
        Dim ranNum2 As Integer
        Dim ranNum3 As Integer
        ranNum1 = Int((255 - 2) * Rnd())
        ranNum2 = Int((255 - 2) * Rnd())
        ranNum3 = Int((255 - 2) * Rnd())
        Me.BackColor = Color.FromArgb((ranNum1), (ranNum2), (ranNum3))

        wordPlace()
        wordsMissed = (length - inputLength)
        lblNotAt.Text = ("Words left: " + CStr(wordsMissed))
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            wordPlace()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtInput.Text = "" Then
            MessageBox.Show("TYpe sompthing")
        End If
        input = Split((txtInput.Text), " ")
        score = 0
        wordPlace()
        finalScore = ("Score: " + CStr(score))
        lblScore.Text = finalScore
        MessageBox.Show(length, inputLength)
        wordsMissed = (length - inputLength)
        MessageBox.Show(wordsMissed)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = " "
    End Sub

    Private Sub btnGetApi_Click(sender As Object, e As EventArgs) Handles btnGetApi.Click
        'Code sourced from https://www.youtube.com/watch?v=FE4PdSnox1w
        Try
            Dim Request As HttpWebRequest = HttpWebRequest.Create("Http://numbersapi.com/random/trivia")
            Request.Proxy = Nothing 'speeds up request
            'Request.UserAgent = "Test"

            Dim response As HttpWebResponse = Request.GetResponse
            Dim responsestream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responsestream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            Label1.Text = data
        Catch ex As Exception
        End Try
        Label1.Left = (Me.Width / 2) - (Label1.Width / 2)

        'copyTxt = Split(Label1.Text, " ")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeInt = (timeInt + 1)
        time = timeInt / 10

        lblTime.Text = CStr(time) + " seconds"
    End Sub
End Class
