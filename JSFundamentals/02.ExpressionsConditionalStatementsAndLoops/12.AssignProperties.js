function assignProp(arr) {
    [key1, value1, key2, value2, key3, value3] = arr;
    console.log({
        [key1]: value1,
        [key2]: value2,
        [key3]: value3
    });
}