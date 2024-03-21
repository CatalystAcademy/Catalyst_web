<template>
  <client-only>
    <b-nav tabs>
      <b-nav-item><nuxt-link to="/admin/Course/List">Courses</nuxt-link></b-nav-item>
      <b-nav-item> <nuxt-link to="/admin/curriculum/list">Curriculums</nuxt-link></b-nav-item>
      <b-nav-item>Another Link</b-nav-item>
      <b-nav-item disabled>Disabled</b-nav-item>
    </b-nav>
  </client-only>
</template>

<script>
    export default {
        name: "AdminNav"
    }
</script>

<style scoped>
</style>
