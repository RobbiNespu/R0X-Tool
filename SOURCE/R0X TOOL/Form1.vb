Imports System.IO

Public Class Utama
    Public Declare Function FSOUND_Init Lib "fmod.dll" Alias "_FSOUND_Init@12" (ByVal mixrate As Integer, _
                                                                                ByVal maxchannels As Integer, _
                                                                                ByVal flags As Integer) As Byte
    Public Declare Function FMUSIC_LoadSong Lib "fmod.dll" Alias "_FMUSIC_LoadSong@4" (ByVal name As String) As Integer
    Public Declare Function FMUSIC_PlaySong Lib "fmod.dll" Alias "_FMUSIC_PlaySong@4" (ByVal modulee As Integer) As Byte

    Private Sub Utama_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtInput.TextAlign = 2
        txtInput.Text = "< Please write here >"
        txtNilai.Text = tb_julat.Value


        Dim XMFilename As String = "myxmfile.xm"
        ' name of the xm file after extraction.
        Dim TempPath As String = Path.GetTempPath()
        ' get the temp folder path
        Dim ExtractPath As String = TempPath & "\" & XMFilename
        ' file extraction path + xm filename

        ' extract the xm file to your temp folder
        Try
            File.WriteAllBytes(ExtractPath, My.Resources.SMB_X())
        Catch ex As Exception
            MsgBox(ex.Message)
            'if it fails
        End Try
        FSOUND_Init(44001, 128, 0)
        Dim XMPointer As Integer = 0
        XMPointer = FMUSIC_LoadSong(Path.GetTempPath() & "\myxmfile.xm")
        ' path to the xm file in the temp folder
        FMUSIC_PlaySong(XMPointer)
        ' play the music :)
    End Sub

    Private Sub tb_julat_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tb_julat.Scroll
        txtNilai.Text = tb_julat.Value
    End Sub

    Private Sub btn_encrytion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_encrytion.Click
        txtCipher.TextAlign = 2
        txtCipher.Text = EncryptDecrypt(txtInput.Text, txtNilai.Text, True)
        tb_julat.Value = txtNilai.Text
        '<----- satu-satunyer bug yang ada.. iskzz!
    End Sub

    Private Sub btn_Reverse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Reverse.Click
        txt_decrytion.TextAlign = 2
        txt_decrytion.Text = EncryptDecrypt(txtCipher.Text, txtNilai.Text, False)
    End Sub

    Function EncryptDecrypt(ByVal text1 As String, ByVal key As String, ByVal isEncrypt As Boolean) As String
        Dim char1 As String
        Dim char2 As String
        Dim cKey As Byte
        Dim strLength As Integer
        Dim Result As String = ""
        Dim j As Integer = -1
        If text1 <> "" And IsNumeric(key) Then
            strLength = text1.Length
            For i As Integer = 0 To strLength - 1
                char1 = text1.Substring(i, 1)
                If j < key.Length - 1 Then
                    j = j + 1
                Else
                    j = 0
                End If
                cKey = Val(key.Substring(j, 1))
                If isEncrypt Then
                    char2 = Chr(Asc(char1) + cKey)
                Else
                    char2 = Chr(Asc(char1) - cKey)
                End If
                Result &= char2
            Next
        Else
            MsgBox("Enter text or key!")
        End If
        Return Result
    End Function
End Class
