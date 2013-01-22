//! ScriptLibrary1.debug.js
//

(function($) {

Type.registerNamespace('ScriptLibrary1');

Type.registerNamespace('Scripts');

////////////////////////////////////////////////////////////////////////////////
// ScriptLibrary1.Class1

ScriptLibrary1.Class1 = function ScriptLibrary1_Class1() {

    this.customAlertMessage("HELLOCUSTOM0");

}
this.customAlertMessage("HELLOCUSTOM1");
    

////////////////////////////////////////////////////////////////////////////////
// Scripts.TextPreviewer

Scripts.TextPreviewer = function Scripts_TextPreviewer(textElementId, divElementId) {
    /// <param name="textElementId" type="String">
    /// </param>
    /// <param name="divElementId" type="String">
    /// </param>
    /// <field name="_text" type="Object" domElement="true">
    /// </field>
    /// <field name="_div" type="Object" domElement="true">
    /// </field>
    this._text = document.getElementById(textElementId);
    this._div = document.getElementById(divElementId);
}
Scripts.TextPreviewer.prototype = {
    _text: null,
    _div: null,
    
    initialize: function Scripts_TextPreviewer$initialize() {
        if (!ss.isNullOrUndefined(this._text)) {
            this._text.addEventListener('keyup', ss.Delegate.create(this, this._onKeyUpListener), false);
        }
    },
    
    _onKeyUpListener: function Scripts_TextPreviewer$_onKeyUpListener(e) {
        /// <param name="e" type="ElementEvent">
        /// </param>
        if (!ss.isNullOrUndefined(this._div)) {
            this._div.innerHTML = this._text.value;
        }
    },
    
    testValue: function Scripts_TextPreviewer$testValue() {
        /// <returns type="String"></returns>
        return 'Test Hello World Value String!!!';
    },
    
    factor: function Scripts_TextPreviewer$factor(j) {
        /// <param name="j" type="Number" integer="true">
        /// </param>
        /// <returns type="Number" integer="true"></returns>
        var sum = 0;
        for (var i = 0; i < j; i++) {
            sum = sum + i;
        }
        return sum;
    },
    
    customAlertMessage: function Scripts_TextPreviewer$customAlertMessage(msg) {
        /// <param name="msg" type="String">
        /// </param>
        alert('Custom: ' + msg);
    }
}


ScriptLibrary1.Class1.registerClass('ScriptLibrary1.Class1');
Scripts.TextPreviewer.registerClass('Scripts.TextPreviewer');
})(jQuery);

//! This script was generated using Script# v0.7.4.0
