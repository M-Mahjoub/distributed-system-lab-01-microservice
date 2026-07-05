# Domain Event Rules

1. Domain Events are raised by Aggregate Roots.

2. Domain Events are dispatched only after a successful Commit.

3. The order of Domain Events raised by an Aggregate must be preserved.

4. Handlers should not depend on each other.
