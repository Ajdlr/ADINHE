﻿/// <reference path="../Order/OrderDialog.ts" />

namespace Serene1.Northwind {

    @Serenity.Decorators.registerClass()
    export class CustomerOrderDialog extends OrderDialog {

        constructor() {
            super();
        }

        updateInterface() {
            super.updateInterface();

            Serenity.EditorUtils.setReadOnly(this.form.CustomerID, true);
        }
    }
}