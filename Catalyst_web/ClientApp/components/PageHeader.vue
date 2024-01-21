<template>
  <section class="inner-banner">
      <div class="container">
          <ul class="list-unstyled thm-breadcrumb">
              <li><a href="/">Home</a></li>
              <li class="active"><a href="#">{{ title }}</a></li>
          </ul><!-- /.list-unstyled -->
          <h2 class="inner-banner__title">{{ title }}</h2><!-- /.inner-banner__title -->
      </div><!-- /.container -->
  </section>
</template>

<script>
    export default {
      name: "PageHeader",
      props: {
        title: {
          type: String
        }
      }
    }
</script>

<style scoped>

</style>
