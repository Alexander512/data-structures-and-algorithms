class StaticArray {

    /*
        The constructor will represent the build step for the
        static array. This is an O(n) time complexity operation.
    */
    constructor(length: number) {
        if (length < 0) throw new Error('length out of range')

        this.count = length
        this.data = new Array(length)
    }

    count: number
    data: number[]

    // Return the length with an O(1) time complexity.
    length(): number {
        return this.count
    }

    // Get the value at the given index with an O(1) time complexity.
    getAt(index: number): number {
        if (index < 0 || index >= this.count) throw new Error('index out of range')
        return this.data[index]
    }

    // Set the value at the given index with an O(1) time complexity.
    setAt(index: number, value: number): void {
        if (index < 0 || index >= this.count) throw new Error('index out of range')
        this.data[index] = value 
    }

    iterSequence(): void {
        for (let i: number = 0; i < this.count; i++) {
            console.log(`index: ${i}\tvalue: ${this.data[i]}`)
        }
    }

}

// Create a new static array which is an O(n) time complexity operation.
const array: StaticArray = new StaticArray(10)

// Get and set operations both with an O(1) time complexity.
array.setAt(0, 1)
const result = array.getAt(0)

console.log(`result of setting and getting: ${result}`)
console.log(`length of the array: ${array.length()}`)

array.iterSequence()
