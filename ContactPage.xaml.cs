using System;
using BallonParty.Models;
using BallonParty.Services;
using Microsoft.Maui.Controls;

namespace BallonParty;

public partial class ContactPage : ContentPage
{
    private readonly MongoDBService _mongoDBService;

    public ContactPage()
    {
        InitializeComponent();
        _mongoDBService = new MongoDBService();
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        var nuevaCita = new Cita
        {
            NombreCompleto = nombreEntry.Text,
            CorreoElectronico = correoEntry.Text,
            Telefono = telefonoEntry.Text,
            DetallesEvento = detallesEditor.Text
        };

        await _mongoDBService.AddCitaAsync(nuevaCita);
        await DisplayAlert("Éxito", "La cita ha sido agendada correctamente.", "OK");

        // Limpiar campos después de enviar
        nombreEntry.Text = string.Empty;
        correoEntry.Text = string.Empty;
        telefonoEntry.Text = string.Empty;
        detallesEditor.Text = string.Empty;
    }
}
