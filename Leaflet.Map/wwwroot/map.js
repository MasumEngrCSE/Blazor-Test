let showOrUpdate = (elementId, zoom, markers) => {
    let elem = document.getElementById(elementId);
    if (!elem) {
        throw new Error('No element with ID ' + elementId);
    }
    // Initialize map if needed
    if (!elem.map) {
        elem.map = L.map(elementId).setView([50.88022, 4.29660], zoom);
        L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{ y } ? access_token = pk.eyJ1IjoibWFzdW1iZCIsImEiOiJjbGZzbHdrMmEwN2IxM2dxa3p2bHdybHo4In0.NhUB54ExeHAaPf7EV52XaA', {
attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/
copyright">OpenStreetMap</a> contributors, Imagery © <a href="https://www.
            mapbox.com / ">Mapbox</a>',
maxZoom: 18,
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1,
            accessToken: 'pk.eyJ1IjoibWFzdW1iZCIsImEiOiJjbGZzbHdrMmEwN2IxM2dxa3p2bHdybHo4In0.NhUB54ExeHAaPf7EV52XaA'
}).addTo(elem.map);
}
    export { showOrUpdate };

        ////https://account.mapbox.com/access-tokens
        //mapB_321#