module.exports.loop = function () {
    // requires
    let _ = require('lodash');
    // let spawner = require('spawn.cs');
    // let screeper = require('screep.cs');
    
    /////////////
    // dig graves
    _.forEach(Memory.creeps, (obj,k) => {
        let c = JSON.stringify(k); // the hashkey (ie: its his name)
       if ( !Game.creeps[k]) {
            delete Memory.creeps[k];
            console.log('Buried ' + c + '. They were dead.');
            // Game.notify('Buried ' + c + '. They were dead.',5);
        } 
    });

    /////////////
    //
    /////////////
    console.log("CPU Used / Bucket: " + Game.cpu.getUsed() + " / " + Game.cpu.bucket );
}
