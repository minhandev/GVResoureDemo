

function ReadGrid(_nameGrid) {
    var grid = $('#' + _nameGrid).data('kendoGrid').dataSource.read();
    grid.refresh();
}