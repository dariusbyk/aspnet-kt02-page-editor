tinymce.init({
    selector: '#editor',
    license_key: 'gpl',
    menubar: false,
    plugins: 'lists',
    toolbar: 'undo redo | blocks | bullist numlist',
    height: 350
});

function formatText(command) {
    var editor = tinymce.get('editor');
    editor.focus();
    editor.execCommand(command);
}

function saveEditor() {
    tinymce.triggerSave();
}
