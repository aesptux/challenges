var byteExchange = function (coin) {
    return coin === 0 ? 1 : byteExchange(Math.floor(coin/2)) + byteExchange(Math.floor(coin/3)) + byteExchange(Math.floor(coin/4));
};
console.log(byteExchange(7));