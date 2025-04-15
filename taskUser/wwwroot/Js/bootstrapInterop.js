window.bootstrapInterop = {
    mostrarModal: function (idModal) {
        const modalElement = document.getElementById(idModal);
        if (modalElement) {
            const modal = new bootstrap.Modal(modalElement);
            modal.show();
        }
    },

    ocultarModal: function (selector) {
        const modalElement = document.querySelector(selector);
        if (modalElement) {
            const modal = bootstrap.Modal.getInstance(modalElement);
            if (modal) {
                modal.hide();
            }
        }
    }
};