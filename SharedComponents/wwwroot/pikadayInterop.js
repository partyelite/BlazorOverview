(function (pikadayJLPrepaidWebInterop) {
    pickerInstances = [];

    pikadayJLPrepaidWebInterop.initialize = (element, blazorInstance) => {
        pickerInstances.push({
            id: element.id,
            blazorInstance
        });
        new Pikaday({
            field: document.getElementById(element.id),
            onSelect: function (date) {
                document.getElementById(element.id).value = date ? `${date.getDate()}.${date.getMonth() + 1}.${date.getFullYear()}.` : undefined;
                for (var k = 0; k < pickerInstances.length; k++) {
                    if (pickerInstances[k].id == element.id) {
                        pickerInstances[k].blazorInstance.invokeMethodAsync('ShowPikaday', date);
                        break;
                    }
                }
            },
            yearRange: [new Date().getFullYear() - 100, new Date().getFullYear() + 2],
            i18n: pikadayJLPrepaidWebInterop.i18nhr            
        });
    };

    pikadayJLPrepaidWebInterop.dispose = (element) => {
        for (var k = 0; k < pickerInstances.length; k++) {
            if (pickerInstances[k].id == element.id) {
                pickerInstances.splice(k, 1);
                break;
            }
        }
    }


}(window.pikadayJLPrepaidWebInterop = window.pikadayJLPrepaidWebInterop || {}));