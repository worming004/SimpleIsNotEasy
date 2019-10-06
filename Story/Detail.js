function decode(sentence) {
    return sentence
        .split(';')
        .map(w => w.replace('&#', ''))
        .map(w => parseInt(w, 10))
        .map(i => String.fromCharCode(i))
        .join('');
}

let sentence = '&#72;&#101;&#108;&#108;&#111;&#32;&#119;&#111;&#114;&#108;&#100;&#33;';
let decodedSentence = decode(sentence);
console.log(decodedSentence);


let removeSpecialChars = (word) => word.replace('&#', '');
let toInt = (word) => parseInt(word, 10);
let toAscii = (integer) => String.fromCharCode(integer);

function decodeReadable(sentence) {
    return sentence
        .split(';')
        .map(removeSpecialChars)
        .map(toInt)
        .map(toAscii)
        .join('');
}

let sentence = '&#72;&#101;&#108;&#108;&#111;&#32;&#119;&#111;&#114;&#108;&#100;&#33;';
let decodedSentence = decodeReadable(sentence);
console.log(decodedSentence);
