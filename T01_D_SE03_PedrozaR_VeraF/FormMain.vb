﻿Public Class frmMain
    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click

        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmCalculadora()

        'Muestra el destino'
        destination.Show()

        'Esconde el Form actual'
        Me.Hide()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Cierra la aplicacion'
        Application.Exit()

    End Sub

    Private Sub btnTextos_Click(sender As Object, e As EventArgs) Handles btnTextos.Click
        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmEntrada

        'Muestra el destino'
        destination.Show

        'Esconde el Form actual'
        Me.Hide()
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmCreditos

        'Muestra el destino'
        destination.Show()
        'Esconde el Form actual'
        Me.Hide()
    End Sub
End Class
