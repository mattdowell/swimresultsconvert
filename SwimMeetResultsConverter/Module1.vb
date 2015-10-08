Imports System.Data.OleDb

Module DataAccess

    Public athleteDbConn As New System.Data.OleDb.OleDbConnection()
    Public meetDbConn As New System.Data.OleDb.OleDbConnection()

    Sub convert()
        Try
            ConnectToAthletesReferenceDB()
            ConnectToMeetDB()
            Try
                dropAthletesTable()
            Catch ex As Exception
                ' No worries here
            End Try

            createAthletesTable()
            buildAthletesTable()
            updateMeetDb()

            MessageBox.Show("Completed")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        Finally
            closeAthletesReferenceDB()
            closeMeetDB()
        End Try

    End Sub

    Sub updateMeetDb()
        Dim relay1Query As String = "UPDATE Results, TRU_ATHLETE, Athlete set Results.RelayLeg1_Ath_no = TRU_ATHLETE.Ath_no WHERE Results.RelayLeg1_Ath_no = Athlete.Ath_no and Athlete.Last_name=TRU_ATHLETE.Last_name and Athlete.First_name=TRU_ATHLETE.First_name;"
        Dim relay2Query As String = "UPDATE Athlete, TRU_ATHLETE, Results set Results.RelayLeg2_Ath_no = TRU_ATHLETE.Ath_no WHERE Results.RelayLeg2_Ath_no = Athlete.Ath_no and Athlete.Last_name = TRU_ATHLETE.Last_name and Athlete.First_name=TRU_ATHLETE.First_name;"
        Dim relay3Query As String = "UPDATE Athlete, TRU_ATHLETE, Results set Results.RelayLeg3_Ath_no = TRU_ATHLETE.Ath_no WHERE Results.RelayLeg3_Ath_no = Athlete.Ath_no  and Athlete.Last_name=TRU_ATHLETE.Last_name And Athlete.First_name=TRU_ATHLETE.First_name;"
        Dim relay4Query As String = "UPDATE Athlete, TRU_ATHLETE, Results set Results.RelayLeg4_Ath_no = TRU_ATHLETE.Ath_no WHERE Results.RelayLeg4_Ath_no = Athlete.Ath_no and Athlete.Last_name=TRU_ATHLETE.Last_name And Athlete.First_name=TRU_ATHLETE.First_name;"
        Dim resultsQuery As String = "UPDATE Athlete, TRU_ATHLETE, Results set Results.Ath_no = TRU_ATHLETE.Ath_no WHERE Results.Ath_no = Athlete.Ath_no and Athlete.Last_name=TRU_ATHLETE.Last_name And Athlete.First_name=TRU_ATHLETE.First_name"
        Dim divingQuery As String = "UPDATE Results set Event_Strokename='1 mtr Diving' where Event_Strokename like '1 mtr';"
        Dim meetName As String = "UPDATE Results set Event_Note='" & mainForm.meetName.Text & "'"

        Dim updateRelay1 As OleDbCommand = New OleDbCommand(relay1Query, meetDbConn)
        Dim updateRelay2 As OleDbCommand = New OleDbCommand(relay2Query, meetDbConn)
        Dim updateRelay3 As OleDbCommand = New OleDbCommand(relay3Query, meetDbConn)
        Dim updateRelay4 As OleDbCommand = New OleDbCommand(relay4Query, meetDbConn)
        Dim updateResults As OleDbCommand = New OleDbCommand(resultsQuery, meetDbConn)
        Dim updateDiving As OleDbCommand = New OleDbCommand(divingQuery, meetDbConn)
        Dim updateMeetName As OleDbCommand = New OleDbCommand(meetName, meetDbConn)

        updateRelay1.ExecuteNonQuery()
        updateRelay2.ExecuteNonQuery()
        updateRelay3.ExecuteNonQuery()
        updateRelay4.ExecuteNonQuery()
        updateResults.ExecuteNonQuery()
        updateDiving.ExecuteNonQuery()
        updateMeetName.ExecuteNonQuery()

    End Sub

    Sub buildAthletesTable()

        'import the table
        Dim query As String = "SELECT TRU_ATHLETE.Ath_no, TRU_ATHLETE.First_name, TRU_ATHLETE.Last_name FROM TRU_ATHLETE;"
        Dim cmdDatabase As OleDbCommand = New OleDbCommand(query, athleteDbConn)
        Dim athNo
        Dim firstName
        Dim lastName
        Using myReader As OleDbDataReader = cmdDatabase.ExecuteReader()
            Dim insertQuery As String = "Insert Into TRU_ATHLETE(Ath_no, First_name, Last_name) Values (@athNoParam, @firstNameParam, @lastNameParam)"
            While myReader.Read()
                ' Get the values
                athNo = myReader.GetInt32(0)
                firstName = myReader.GetString(1)
                lastName = myReader.GetString(2)

                ' Insert them in to the meet DB
                Dim insertAtheleteRow As OleDbCommand = New OleDbCommand(insertQuery, meetDbConn)
                insertAtheleteRow.Parameters.AddWithValue("@athNoParam", athNo)
                insertAtheleteRow.Parameters.AddWithValue("@firstNameParam", firstName)
                insertAtheleteRow.Parameters.AddWithValue("@lastNameParam", lastName)
                insertAtheleteRow.ExecuteNonQuery()
            End While
        End Using
    End Sub

    Public Sub createAthletesTable()
        Dim query As String = "CREATE TABLE TRU_ATHLETE (Ath_no INTEGER, First_name CHAR, Last_name CHAR);"
        Dim cmdDatabase As OleDbCommand = New OleDbCommand(query, meetDbConn)
        cmdDatabase.ExecuteNonQuery()
    End Sub

    Public Sub dropAthletesTable()
        ' Drop the table if it exists
        Dim dropTableQuery As String = "DROP TABLE TRU_ATHLETE;"
        Dim dropTableCmd As OleDbCommand = New OleDbCommand(dropTableQuery, meetDbConn)
        dropTableCmd.ExecuteNonQuery()
    End Sub

    Public Sub ConnectToAthletesReferenceDB()
        ' TODO: Modify the connection string and include any
        ' additional required properties for your database.
        athleteDbConn.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" &
    mainForm.athleteDbLocation.Text

        Try
            athleteDbConn.Open()
            ' Insert code to process data.
        Catch ex As Exception
            MessageBox.Show("Failed to connect to athlete database")
        Finally
        End Try
    End Sub

    Public Sub closeAthletesReferenceDB()
        athleteDbConn.Close()
    End Sub

    Public Sub ConnectToMeetDB()

        meetDbConn.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" &
        mainForm.meetDbLocation.Text()

        Try
            meetDbConn.Open()
            ' Insert code to process data.
        Catch ex As Exception
            MessageBox.Show("Failed to connect to meeet database")
        Finally
        End Try
    End Sub

    Public Sub closeMeetDB()
        meetDbConn.Close()
    End Sub

End Module
