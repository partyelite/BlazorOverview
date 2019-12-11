// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.blazorUtilsJs = {
   
    alert: function (message) {
        return alert(message);
    }
};
