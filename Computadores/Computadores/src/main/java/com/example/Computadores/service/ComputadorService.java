package com.example.Computadores.service;

import com.example.Computadores.model.Computador;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class ComputadorService {

    private static ComputadorService instancia;

    private List<Computador> lista = new ArrayList<>();

    private ComputadorService() {
    }

    public static synchronized ComputadorService getInstancia() {
        if (instancia == null) {
            instancia = new ComputadorService();
        }
        return instancia;
    }

    // --- Tus métodos de lógica se mantienen igual ---

    public void agregar(Computador c) {
        c.setActivo(true);
        lista.add(c);
    }

    public Computador buscarPorCodigo(int codigo) {
        for (Computador c : lista) {
            if (c.getCodigo() == codigo && c.isActivo()) {
                return c;
            }
        }
        return null;
    }

    public boolean eliminar(int codigo) {
        Computador c = buscarPorCodigo(codigo);
        if (c == null) return false;
        c.setActivo(false);
        return true;
    }

    public boolean actualizar(int codigo, Computador nuevo) {
        Computador existente = buscarPorCodigo(codigo);
        if (existente == null) return false;

        existente.setMarca(nuevo.getMarca());
        existente.setFechaFabricacion(nuevo.getFechaFabricacion());
        existente.setEstado(nuevo.getEstado());
        existente.setPortatil(nuevo.isPortatil());
        existente.setCostoMantenimiento(nuevo.getCostoMantenimiento());
        existente.setPerifericos(nuevo.getPerifericos());
        return true;
    }

    public List<Computador> listarTodos() {
        List<Computador> activos = new ArrayList<>();
        for (Computador c : lista) {
            if (c.isActivo()) activos.add(c);
        }
        return activos;
    }

    public List<Computador> filtrarPorMarca(String marca) {
        List<Computador> resultado = new ArrayList<>();
        for (Computador c : lista) {
            if (c.isActivo() && c.getMarca().equalsIgnoreCase(marca)) {
                resultado.add(c);
            }
        }
        return resultado;
    }

    public List<Computador> filtrarPorEstado(String estado) {
        List<Computador> resultado = new ArrayList<>();
        for (Computador c : lista) {
            if (c.isActivo() && c.getEstado().equalsIgnoreCase(estado)) {
                resultado.add(c);
            }
        }
        return resultado;
    }
}