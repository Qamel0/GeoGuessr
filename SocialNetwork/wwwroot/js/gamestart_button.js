document.addEventListener('DOMContentLoaded', () => {
    const button = document.getElementById('gamestart');
    const blur = document.querySelector('.blur');
    const background = document.getElementById('mapBackground');
    const container = document.querySelector('.location-container')

    button.addEventListener('click', () => {
        button.style.display = 'none';
        blur.style.display = 'none';
        background.style.display = 'none';


        const lat = (Math.random() * 180 - 90).toFixed(6);
        const lng = (Math.random() * 360 - 180).toFixed(6);

        const iframe = document.createElement('iframe');
        iframe.id = 'location';
        iframe.src = convertMapLink("https://www.google.com/maps/@34.7965414,-84.9608698,3a,75y,0.14h,90t/data=!3m7!1e1!3m5!1skJmfhUWMa-9t7qoIp19qcQ!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fcb_client%3Dmaps_sv.tactile%26w%3D900%26h%3D600%26pitch%3D0%26panoid%3DkJmfhUWMa-9t7qoIp19qcQ%26yaw%3D0.13841248!7i13312!8i6656?entry=ttu&g_ep=EgoyMDI1MDEyNi4wIKXMDSoASAFQAw%3D%3D");
        iframe.style.width = '100%';
        iframe.style.height = '100%';
        iframe.style.border = '0';
        iframe.allowFullscreen = true;
        iframe.loading = 'lazy';

        container.appendChild(iframe);
    });
});

function convertMapLink(inputUrl) {
    const pattern = /@([0-9.-]+),([0-9.-]+),([^/]+)a,([0-9.-]+)y,([0-9.-]+)h,([0-9.-]+)t/;
    const match = inputUrl.match(pattern);

    if (match) {
        const latitude = match[1];
        const longitude = match[2];
        const angle = match[4];
        const yaw = match[5];
        const height = match[6];

        const newUrl = `https://www.google.com/maps/embed?pb=!4v1641255610974!6m8!1m7!1sCAoSLEFGMVFpcE1IcWl5TzFwZzJMSzJrTV9nZzMyUlpxd0ctYmYwVWxZY0VlbHZv!2m2!1d${latitude}!2d${longitude}!3f${angle}!4f0!5f0.1`;
        return newUrl;
    }
    else {
        console.log("Wrong link");
        return null;
    }
}