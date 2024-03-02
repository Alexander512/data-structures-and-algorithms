class StaticArray {
    constructor(length: number) {
        if (length <= 0) throw new Error('length out of range')

        this.length = length
        this.data = new Array(length)
        this.initialize()
    }

    data: number[]
    length: number

    getAt(i: number): number {
        if (i < 0 || i >= this.length) {
            throw new Error('index out of range')
        } else {
            return this.data[i]
        }
    }

    setAt(i: number, value: number): void {
        if (i < 0 || i >= this.length) {
            throw new Error('index out of range')
        } else {
            this.data[i] = value
        }
    }

    initialize(): void {
        for (let i: number = 0; i < this.length; i++) {
            this.data[i] = 0
        }
    }
}

// a new static array of length n
// O(n) time complexity and O(n) space complexity
const array = new StaticArray(10)

// get value at index i
// O(1) time complexity and O(1) space complexity
const value = array.getAt(0)

// set value at index i
// O(1) time complexity and O(1) space complexity
array.setAt(0, 1)

console.log(`static array: ${array.data}`)
