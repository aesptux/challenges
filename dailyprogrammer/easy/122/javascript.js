var digitalRoot = function(n) {
    while (n > 9) {
        n = digitalRoot(Math.floor(n = (n % 10) + (n / 10)));
    }
    return n;
};
console.log(digitalRoot (31337));