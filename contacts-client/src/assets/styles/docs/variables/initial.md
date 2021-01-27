# - Initial Variables -
`src/variables/initial.scss` holds our *literal* variables.

## - Summary -
Examples of initial variables would be:

 - Literal colors such as `$green: #50a000;`
 - Literal font sizes such as `$size-1: 2.4rem;`
 - Font weights such as `$weight-bold: 700;`
 - Font families like `$family-sans-serif: "Open Sans", sans-serif;`

 **These can be used as is or derived from in the `derived.scss` file.**

 NOTE: If possible it is *always* best to set derived variables that inherit initial(literal) variables.  This way if we need to change the value of a variable(like our `$primary` color) it can be changed in one line instead of countless lines.

## - Colors -
Literal colors
**NOTE:  Using $green, $red, $orange, or $blue to set primary color, text color, success, warning, danger, or info messages? It is best to use the derived variables instead. See derived.md for full details**

### Usage

Set a color or background color using a literal color variable.
**NOTE: It's best to use our helper classes instead(.has-text-red, .has-background-blue-light, etc.).  See `src/docs/helpers/colors.md`**

```scss
.someClass {
    color: $blue-darker;
    background-color: $yellow-lightest;
}
```

 ## Literal Colors
| Color              | Hex     | Color             | Hex     | Color               | Hex     | Color             | Hex     |
|--------------------|---------|-------------------|---------|---------------------|---------|-------------------|---------|
| $green-super-light | #f6feed | $gray-super-light | #f8f7f6 | $orange-super-light | #fff3e0 | $blue-super-light | #e2e9f3 |
| $green-lightest    | #edfcda | $gray-lightest    | #eceff1 | $orange-lightest    | #fff3e0 | $blue-lightest    | #e2e9f3 |
| $green-lighter     | #c2eda4 | $gray-lighter     | #cfd8dc | $orange-lighter     | #ffe0b2 | $blue-lighter     | #6e93cc |
| $green-light       | #8ddb56 | $gray-light       | #b0bec5 | $orange-light       | #ffa726 | $blue-light       | #3462ae |
| $green             | #50a000 | $gray             | #90a4ae | $orange             | #ff9800 | $blue             | #17489e |
| $green-dark        | #438500 | $gray-dark        | #718792 | $orange-dark        | #e96100 | $blue-dark        | #17489e |
| $green-darker      | #356b00 | $gray-darker      | #455a64 | $orange-darker      | #c43e00 | $blue-darker      | #1e3866 |
| $green-darkest     | #285000 | $gray-darkest     | #1c313a | $orange-darkest     | #c43e00 | $blue-darkest     | #1e3866 |

## Literal Colors Continued
| Color             | Hex     | Color               | Hex     | Color            | Hex     | Color               | Hex     |
|-------------------|---------|---------------------|---------|------------------|---------|-------------=-------|---------|
| $white            | #ffffff | $yellow-super-light | #fdf6c9 | $red-super-light | #fbe9e7 | $purple-super-light | #f3e5f5 |
| $black            | #000000 | $yellow-lightest    | #fdf6c9 | $red-lightest    | #fbe9e7 | $purple-lightest    | #f3e5f5 |
|                   |         | $yellow-lighter     | #fff490 | $red-lighter     | #ef9a9a | $purple-lighter     | #e1bee7 |
|                   |         | $yellow-light       | #fae64e | $red-light       | #d32f2f | $purple-light       | #ce93d8 |
|                   |         | $yellow             | #f5d80c | $red             | #a91818 | $purple             | #7b1fa2 |
|                   |         | $yellow-dark        | #e0ad09 | $red-dark        | #7f0000 | $purple-dark        | #4a0072 |
|                   |         | $yellow-darker      | #cc8206 | $red-darker      | #4c0000 | $purple-darker      | #33004f |
|                   |         | $yellow-darkest     | #cc8206 | $red-darkest     | #4c0000 | $purple-darkest     | #33004f |

## - Typography -

## Font Sizes
Literal font sizes. Use these just in case font sizes are tweaked later on.

### $size-1: 2.4rem
### $size-2: 1.8rem
### $size-3: 1.6rem
### $size-4: 1.5rem
### $size-5: 1.4rem
### $size-6: 1.3rem
### $size-7: 1.2rem
### $size-8: 1.1rem
### $size-9: 1rem

### Usage
Set a font size using a size variable.  **NOTE: It's preferable to use our helper classes (.is-size-1, .is-size-5, etc.) for this instead. See `src/docs/helpers/typography.md`**

```scss
h1 {
    font-size: $size-1;
}
```

## Font Weights
Literal Font Weights

### $weight-semibold: 600
### $weight-bold: 700
### $weight-normal: 500
### $weight-light: 400

### Usage
Set a font weight using a weight variable.  **NOTE: It's preferable to use our helper classes (.has-text-weight-bold, .has-text-weight-semibold etc.) for this instead. See `src/docs/helpers/typography.md`**

```scss
h1 {
  font-weight: $weight-bold;
}
```

## Font Families
Literal Font Families

$family-sans-serif: "Open Sans", "Helvetica Neue", sans-serif;

**NOTE: Instead of $family-sans-serif you should use the $family-primary derived variable just in case we change our primary font later**

## - Spacing -
Literal spacing values

$section-padding: 2rem
**NOTE: You shouldn't need to set this in the CSS.  Applying the `.section` class to a `<section>` is the preferred way of setting default section padding.**

### Usage
```html
<section class="section">
This section has our default section padding of 2rem.
</section>
```