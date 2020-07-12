export let Data = {
    retrieve: () => {
        let xhr = new XMLHttpRequest();
        
        xhr.open("GET", "resume-data.json");

        // todo -> make a request to the server for some json data
        xhr.onreadystatechange = function () {
            if(xhr.readyState === XMLHttpRequest.DONE) {
                const status = xhr.status;
                
                if (status === 0 || (status >= 200 && status < 400)) {
                } else {
                }
            }
        };

        xhr.send();
    }
}