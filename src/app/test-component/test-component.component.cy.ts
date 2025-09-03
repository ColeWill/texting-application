import { TestComponentComponent } from './test-component.component'

describe('TestComponentComponent', () => {
  it('should mount', () => {
    cy.mount(TestComponentComponent)
  })
})