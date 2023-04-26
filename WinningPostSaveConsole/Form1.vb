Imports System.IO
Imports System.Text

Public Class Form1
    Dim officialSaveList As List(Of SaveData)
    Dim backupSaveList As List(Of SaveData)
    Dim MaxBackupId As Integer = -1
    Public Structure SaveData
        Dim WPDate, WPName, Difficulty, IsVirtual, StartYear, Farms As String
        Dim Id, Blue, Bronze, Silver, Gold, Rainbow, Money As Integer
        Dim RealYear, RealMonth, RealDay, SecOfDay As Integer
        Public Function hash() As ULong
            Dim _hash As ULong = RealYear
            _hash <<= 8
            _hash += RealMonth
            _hash <<= 8
            _hash += RealDay
            _hash <<= 32
            _hash += SecOfDay
            Return _hash
        End Function
        Private Function stringMoney() As String
            Dim Ret = ""
            If Money >= 100000000 Then
                Ret += (CInt(Money / 100000000) Mod 10000).ToString() + "兆"
                Ret += (CInt(Money / 10000) Mod 10000).ToString("0000") + "億"
                Ret += ((Money) Mod 10000).ToString("0000") + "万円"
            ElseIf Money >= 10000 Then
                Ret += (CInt(Money / 10000) Mod 10000).ToString() + "億"
                Ret += ((Money) Mod 10000).ToString("0000") + "万円"
            Else
                Ret += ((Money) Mod 10000).ToString() + "万円"
            End If
            Return Ret
        End Function

        Public Function toItem() As ListViewItem
            Dim h, m, s As Integer
            h = math.Floor(secofday / 4096)
            m = Math.Floor((SecOfDay - 4096 * h) / 60)
            s = Math.Floor((SecOfDay - 4096 * h - 60 * m))
            Return New ListViewItem({Me.Id.ToString(), Me.WPDate, Me.WPName, stringMoney(), Farms, Me.Blue, Me.Bronze, Me.Silver, Me.Gold, Me.Rainbow, Me.Difficulty, Me.IsVirtual, Me.StartYear, $"{RealYear}/{RealMonth}/{RealDay} {h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}"})
        End Function

    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        officialSaveList = New List(Of SaveData)
        backupSaveList = New List(Of SaveData)
        LoadWPSaveData()
    End Sub
    Private Sub LoadWPSaveData()
        Dim files = System.IO.Directory.GetFiles(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\Savedata", "WPSVDT*.SD9")
        For Each file In files
            Dim sData = ReadSaveData(file)
            officialSaveList.Add(sData)
            ListView1.Items.Add(sData.toItem())
        Next
        files = System.IO.Directory.GetFiles(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\SaveConsole", "WPSVDT*.SD9")
        For Each file In files
            Dim sData = ReadSaveData(file)
            backupSaveList.Add(sData)
            ListView2.Items.Add(sData.toItem())
            MaxBackupId = Math.Max(MaxBackupId, sData.Id)
        Next
        Return
    End Sub
    Private Function ReadSaveData(ByVal file As String) As SaveData
        Dim fileId = CInt(System.IO.Path.GetFileNameWithoutExtension(file).Substring(6))
        Dim fs = New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim bin(52) As Byte
        fs.Read(bin, 0, 52)
        fs.Close()
        Dim month = bin(1) + 1
        Dim week = bin(2) + 1
        Dim difficulty = bin(3)
        Dim IsVirtual = (bin(4) = 2)
        Dim StartYearAndFarm = bin(5)
        Dim Blue = bin(6)
        Dim Bronze = bin(7)
        Dim Silver = bin(8)
        Dim Gold = bin(9)
        Dim Rainbow = bin(10)
        Dim Name = Encoding.GetEncoding("Shift_JIS").GetString(bin, 11, 12)
        Dim Money = BitConverter.ToInt32(bin, 24)
        Dim Year = BitConverter.ToInt16(bin, 28)
        Dim RealYear = BitConverter.ToInt16(bin, 44)
        Dim RealMonth = bin(46)
        Dim RealDay = bin(47)
        Dim SecOfDay = BitConverter.ToInt32(bin, 48)
        Return New SaveData With {
                            .Id = fileId,
                            .WPDate = $"{Year}/{month}/{If(week >= 128, "年末", week.ToString())}",
                            .WPName = Name,
                            .Money = Money,
                            .Blue = Blue,
                            .Bronze = Bronze,
                            .Silver = Silver,
                            .Gold = Gold,
                            .Rainbow = Rainbow,
                            .Difficulty = {"EASY", "NORMAL", "HARD", "EXPERT", "ULTIMATE", "SPECIAL"}(difficulty),
                            .IsVirtual = If(IsVirtual, "仮想", "史実"),
                            .StartYear = {1976, 1984, 1991, 1998, 2005, 2012, 2023}(StartYearAndFarm Mod 8).ToString() + "年",
                            .Farms = "🇯🇵" + If(StartYearAndFarm And 8, "🇺🇸", "　") + {"　", "🇺🇸", "🇨🇦", "🇮🇪", "🇬🇧", "🇮🇹", "🇩🇪", "🇫🇷", "🇦🇺", "🇳🇿", "🇭🇰", "🇦🇪", "🇸🇬", "🇸🇦", "", "", ""}(Math.Floor(StartYearAndFarm / 16)),
                            .RealYear = RealYear,
                            .RealMonth = RealMonth,
                            .RealDay = RealDay,
                            .SecOfDay = SecOfDay
        }

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadOfficalSaves()
    End Sub
    Private Function ReloadOfficalSaves() As Boolean
        Dim files = System.IO.Directory.GetFiles(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\Savedata", "WPSVDT*.SD9")
        Dim IsUpdated = False
        For Each file In files
            Dim sData = ReadSaveData(file)
            If sData.hash() <> officialSaveList(sData.Id).hash() Then
                officialSaveList(sData.Id) = sData
                ListView1.Items(sData.Id) = sData.toItem()
                IsUpdated = True
            End If
        Next
        Return IsUpdated
    End Function
    Private Function MoveSaveData(ByVal src As String, ByVal dest As String) As SaveData
        System.IO.File.Copy(src, dest, True)

        Dim fi As New System.IO.FileInfo(dest)

        If fi.Length < 8839168 Then
            System.IO.File.Delete(dest)
            Return Nothing
        End If

        Return ReadSaveData(dest)

    End Function
    Private Function BackupSaveData(ByVal officialId As Integer, ByVal backupId As Integer) As SaveData
        Dim officialFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\Savedata\" + $"WPSVDT{officialId.ToString("000")}.SD9"
        Dim backupFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\SaveConsole\" + $"WPSVDT{backupId.ToString("000")}.SD9"

        Return MoveSaveData(officialFile, backupFile)
    End Function
    Private Function RestoreSaveData(ByVal officialId As Integer, ByVal backupId As Integer) As SaveData
        Dim officialFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\Savedata\" + $"WPSVDT{officialId.ToString("000")}.SD9"
        Dim backupFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\KoeiTecmo\Winning Post 9 2022\SaveConsole\" + $"WPSVDT{backupId.ToString("000")}.SD9"

        Return MoveSaveData(backupFile, officialFile)
    End Function
    Private Sub SyncSave()
        For Each osd In officialSaveList
            Dim isNotExist = True
            For Each bsd In backupSaveList

                If osd.hash() = bsd.hash() Then
                    isNotExist = False
                    Exit For
                End If
            Next
            If isNotExist Then
                Dim bs = BackupSaveData(osd.Id, MaxBackupId + 1)
                If IsNothing(bs) Then
                    Exit For
                End If
                MaxBackupId += 1
                backupSaveList.Add(bs)
                ListView2.Items.Add(bs.toItem())
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ReloadOfficalSaves() = False Then
            SyncSave()
        Else
            MessageBox.Show("更新があるため実行しませんでした。")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ReloadOfficalSaves() = False Then
            Dim OfficialIndices = ListView1.SelectedIndices
            Dim BackupIndices = ListView2.SelectedIndices
            If OfficialIndices.Count <> BackupIndices.Count Then
                MessageBox.Show("選択されているセーブデータ数が一致しませんでした。")
            Else
                For i = 0 To OfficialIndices.Count - 1
                    RestoreSaveData(OfficialIndices(i), BackupIndices(i))
                    officialSaveList(OfficialIndices(i)) = backupSaveList(BackupIndices(i))
                    ListView1.Items(OfficialIndices(i)) = backupSaveList(BackupIndices(i)).toItem()
                Next
            End If
        Else
            MessageBox.Show("更新があるため実行しませんでした。")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReloadOfficalSaves()
    End Sub

    Private Sub WPSaveFolderOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WPSaveFolderOToolStripMenuItem.Click

    End Sub
End Class
