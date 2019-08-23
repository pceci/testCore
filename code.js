function HacerLimpiezaDeCarritosDspDeConfirmarPedido() {
    if (isHacerBorradoCarritos) {
        if (indexSucursalTransferSeleccionado == null) {
            var indexCarrito = $("#hiddenIndexCarrito").val();
            if (isNotNullEmpty(indexCarrito)) {
                $('#divContenedorCarrito_' + indexCarrito).remove();
                var sucur = listaCarritos[indexCarrito].codSucursal;
                listaCarritos[indexCarrito].codSucursal = '';
                LimpiarTextBoxProductosBuscados(sucur);
                $("#hiddenIndexCarrito").val('');
                carritoNoHayCarritosCelular();
            }
        } else {
            var sucur = listaCarritoTransferPorSucursal[indexSucursalTransferSeleccionado].Sucursal;
            listaCarritoTransferPorSucursal[indexSucursalTransferSeleccionado].Sucursal = '';
            LimpiarTextBoxProductosBuscados(sucur);
            $('#divContenedorBaseTransfer_' + sucur).html('');
            indexSucursalTransferSeleccionado = null;
            carritoNoHayCarritosCelular();
        }
        isHacerBorradoCarritos = false;
    }
}