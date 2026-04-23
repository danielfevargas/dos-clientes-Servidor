import { useState } from "react";
import GUIAgregar from "./GUIAgregar";
import GUIBuscar from "./GUIBuscar";
import GUIListar from "./GUIListar";
import GUIActualizar from "./GUIActualizar";
import GUIEliminar from "./GUIEliminar";
import GUIAcercaDe from "./GUIAcercaDe";

function GUIPrincipal() {

  var [ventanaActiva, setVentanaActiva] = useState("agregar");

  var [mensaje, setMensaje] = useState(null);

  function mostrarMensaje(texto, tipo) {
    setMensaje({ texto: texto, tipo: tipo });
    setTimeout(function() {
      setMensaje(null);
    }, 3000);
  }

  function renderizarVentana() {
    if (ventanaActiva === "agregar") {
      return <GUIAgregar onMensaje={mostrarMensaje} />;
    }
    if (ventanaActiva === "buscar") {
      return <GUIBuscar onMensaje={mostrarMensaje} />;
    }
    if (ventanaActiva === "listar") {
      return <GUIListar onMensaje={mostrarMensaje} />;
    }
    if (ventanaActiva === "actualizar") {
      return <GUIActualizar onMensaje={mostrarMensaje} />;
    }
    if (ventanaActiva === "eliminar") {
      return <GUIEliminar onMensaje={mostrarMensaje} />;
    }
    if (ventanaActiva === "acerca") {
      return <GUIAcercaDe />;
    }
  }

  return (
    <div>
      <div className="navbar">
        <span>ComputerApp</span>

        <button
          className={ventanaActiva === "agregar" ? "activo" : ""}
          onClick={function() { setVentanaActiva("agregar"); }}
        >
          Agregar
        </button>

        <button
          className={ventanaActiva === "buscar" ? "activo" : ""}
          onClick={function() { setVentanaActiva("buscar"); }}
        >
          Buscar
        </button>

        <button
          className={ventanaActiva === "listar" ? "activo" : ""}
          onClick={function() { setVentanaActiva("listar"); }}
        >
          Listar
        </button>

        <button
          className={ventanaActiva === "actualizar" ? "activo" : ""}
          onClick={function() { setVentanaActiva("actualizar"); }}
        >
          Actualizar
        </button>

        <button
          className={ventanaActiva === "eliminar" ? "activo" : ""}
          onClick={function() { setVentanaActiva("eliminar"); }}
        >
          Eliminar
        </button>

        <button
          className={ventanaActiva === "acerca" ? "activo" : ""}
          onClick={function() { setVentanaActiva("acerca"); }}
        >
          Acerca de
        </button>
      </div>

      <div className="contenido">
        {renderizarVentana()}
      </div>

      {mensaje !== null && (
        <div className={"mensaje " + mensaje.tipo}>
          {mensaje.texto}
        </div>
      )}
    </div>
  );
}

export default GUIPrincipal;
