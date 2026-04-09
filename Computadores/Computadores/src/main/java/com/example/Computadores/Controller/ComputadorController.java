package com.example.Computadores.Controller;

import com.example.Computadores.model.Computador;
import com.example.Computadores.service.ComputadorService;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/computadores")
@CrossOrigin(origins = "*")
public class ComputadorController {

    private ComputadorService service = new ComputadorService();


    @GetMapping("/healthCheck")
    public String healthCheck() {
        return "Servicio Computadores Ok!";
    }


    @PostMapping
    public ResponseEntity<Computador> crear(@RequestBody Computador c) {
        service.agregar(c);
        return ResponseEntity.ok(c);
    }


    @GetMapping
    public ResponseEntity<List<Computador>> listar(
            @RequestParam(required = false) String marca,
            @RequestParam(required = false) String estado) {

        if (marca != null) {
            return ResponseEntity.ok(service.filtrarPorMarca(marca));
        }
        if (estado != null) {
            return ResponseEntity.ok(service.filtrarPorEstado(estado));
        }
        return ResponseEntity.ok(service.listarTodos());
    }


    @GetMapping("/{codigo}")
    public ResponseEntity<Computador> buscar(@PathVariable int codigo) {
        Computador c = service.buscarPorCodigo(codigo);
        if (c == null) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(c);
    }


    @PutMapping("/{codigo}")
    public ResponseEntity<String> actualizar(@PathVariable int codigo,
                                             @RequestBody Computador nuevo) {
        Computador existente = service.buscarPorCodigo(codigo);
        if (existente == null) {
            return ResponseEntity.notFound().build();
        }
        service.actualizar(codigo, nuevo);
        return ResponseEntity.ok("Computador actualizado");
    }


    @DeleteMapping("/{codigo}")
    public ResponseEntity<String> eliminar(@PathVariable int codigo) {
        Computador existente = service.buscarPorCodigo(codigo);
        if (existente == null) {
            return ResponseEntity.notFound().build();
        }
        service.eliminar(codigo);
        return ResponseEntity.ok("Computador eliminado");
    }
}