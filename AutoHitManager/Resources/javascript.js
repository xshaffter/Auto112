let run_data_frame;
let last_update = "";

function doUpdateFrame() {
    try {
        run_data_frame.src = run_data_frame.src;
        Watchdog();
    } catch {

    }
}

var heartbeat = 0;
var init_done = false;
function Watchdog() {
    setTimeout(function () { Watchdog(); }, 300); // refresh every second
    if (heartbeat <= 1)
        heartbeat++;
    else {
        run_data_frame.src = run_data_frame.src; // retry reloading file in case of errors
    }
}
var last_update_time = 0;
function DoUpdate(run_info) {
    heartbeat = 0;
    init_done = true;
    if (run_info.last_update !== last_update) {
        last_update = run_info.last_update;
        doUpdateData(run_info);
    }
    setTimeout(function () { run_data_frame.src = run_data_frame.src; }, 300);
}

window.onload = function () {
    run_data_frame = document.getElementById("run_data_frame");
    doUpdateFrame();
}