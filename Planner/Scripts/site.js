$(document).ready(function () {
    AddModalClick();
    LoadTaskList();  
});

function AddHandlers() {
    EditModalClick();
    RemoveTask();
}

function AddModalClick()
{
    $(".add-task").on("click", function () {
        $(".modal-content").load('/Home/AddTask');
    });
}

function EditModalClick()
{
    $(".edit-task").on("click", function () {
        var id = $(event.target).attr('id-val');
        $('.modal-content').load('/Home/EditTask?id=' + id);
    });
}

function LoadTaskList() {
    $('#task-list').load('/Home/TaskList');
}

function RemoveTask()
{
    $(".del-task").on("click", function () {
        var id = $(event.target).val();
        $('#task-list').load('/Home/DeleteTask?id=' + id);
    });
}
