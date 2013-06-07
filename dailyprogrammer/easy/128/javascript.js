var sum = function(n) {
    return n < 10 ? n : sum(n.toString().split('').reduce(function (a, b) {
        return parseInt(a) + parseInt(b);
    }))
};

console.log(sum(12345));
