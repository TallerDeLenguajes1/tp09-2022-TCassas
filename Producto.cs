using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Producto {
    [JsonPropertyName("nombre")]
    public string Nombre {get; set;}

    [JsonPropertyName("fechaVencimiento")]
    public string FechaVencimiento {get; set;}

    [JsonPropertyName("precio")]
    public float Precio {get; set;}

    [JsonPropertyName("tamanio")]
    public int Tamanio {get; set;}

    public Producto(string nombre, string fechaVencimiento, float precio, int tamanio) {
        this.Nombre = nombre;
        this.FechaVencimiento = fechaVencimiento;
        this.Precio = precio;
        this.Tamanio = tamanio;
    }
}