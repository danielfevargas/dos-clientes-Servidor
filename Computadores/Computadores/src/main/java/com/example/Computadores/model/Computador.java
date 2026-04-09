package com.example.Computadores.model;

import com.fasterxml.jackson.annotation.JsonFormat;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDateTime;
import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Computador {
    private int codigo;
    private String marca;
    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    private LocalDateTime fechaFabricacion;
    private String estado;
    private boolean portatil;
    private Double costoMantenimiento;
    private boolean activo = true;
    private List<String> perifericos;
}
