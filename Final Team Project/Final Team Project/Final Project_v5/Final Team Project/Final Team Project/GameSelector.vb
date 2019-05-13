﻿Imports System.IO

Public Class GameSelector
    Dim frmQuestion As New QuestionForm1

    Private Sub GameSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Play the audio for the game.
        ' My.Computer.Audio.Play("E:\Final Project_v5\Final Team Project\Undertale OST 021 - Dogsong.wav", AudioPlayMode.BackgroundLoop)

        ' Display the game directions.
        MessageBox.Show("Welcome to The Best 'Bored' Game! To upload a previous set of questions, choose 'Select Game'. To create a new set, choose 'Create Game'.")
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Call the module function that creates a game file.
        NameForm()

        ' Find the number of questions the user wants, call the module function.
        intText = NumOfQuestion()

        ' Check to see if the number of questions is between 1 and 30.
        If intText > 1 And intText < 30 Then
            ' If it is, open the question form to enter the questions.
            frmQuestion.ShowDialog()

            ' After the questions are created, open the game board.
            GameForm.ShowDialog()
        Else
            ' If the number is not between 1 and 30, reenter the number of questions.
            intText = NumOfQuestion()
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Enter the name of the file that has already been created.
        strFileName = InputBox("Enter the file's name.")

        ' Open the game board.
        GameForm.ShowDialog()
    End Sub
End Class