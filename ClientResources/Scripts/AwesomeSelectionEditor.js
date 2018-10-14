define([
// Dojo
    "dojo/_base/declare",
    "dojo/_base/array",

    "dojox/html/entities",
// EPi
    "epi-cms/contentediting/editors/SelectionEditor",

// Resources
    "epi/i18n!epi/cms/nls/episerver.cms.widget.contentselector",

    'xstyle/css!//stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css'
],
function (
// Dojo
    declare,
    array,
    entities,

// EPi
    SelectionEditor,

// Resources
    res
) {
    return declare("addon-property-fontawesomedropdown/AwesomeSelectionEditor", [SelectionEditor], {

        // tags:
        //      internal

        // missingMessage: [public] String
        //    Message which is displayed when required is true and value is empty.
        missingMessage: res.requiredmessage,

        validator: function (/*Object*/value, /*Object?*/ flags) {
            // summary:
            //      Validate the value is match with anchor type.
            // tags:
            //      public override

            return !!value;
        },

        isValid: function () {
            // summary:
            //      Overidden base class for validate function
            // tags:
            //      protected

            return !!this.value;
        },

        // override to skip encoding
        _setSelectionsAttr: function (newSelections) {
            this.set("options", array.map(newSelections, function (item) {
                return {
                    label: item.text,
                    value: item.value,
                    selected: item.value === this.value || !item.value && !this.value
                };
            }, this));
        }
    });
});